<!-- Component HomePage-->
<template>
    <div class="post">
        <h1 id="msg">Welcome to the American Automobiles Dealership</h1>
        <table width="90%">
            <tr>
                <td>
                    <table width="100%">
                        <tr>
                            <td align="center" width="30px">
                                Search<input id="search" v-model="parameters.search" placeholder="Search by Model">
                            </td>
                            <td width="40px" align="center">
                                Filter<select id="filter" v-model="parameters.id">
                                    <option value="1">Dealer 1</option>
                                    <option value="2">Dealer 2</option>
                                </select>
                                Sort by<select id="sortby" v-model="parameters.sort">
                                    <option value="">Select One</option>
                                    <option value="model">Model</option>
                                    <option value="price">Price</option>
                                </select>
                            </td>
                            <td width="10px">
                                
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr align="center">
                <td>
                    <div class="content">
                        <TableBase :header="header" :post="post"></TableBase>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</template>

<script lang="js">
    import { defineComponent } from 'vue';
    import TableBase from '../components/TableBase.vue'

    export default defineComponent({
        components: { TableBase },
        data() {
            return {
                parameters: { id: 1, search: '', sort: '' },
                loading: false,
                post: null,
                header: [
                    { title: 'Model', key: 'model' },
                    { title: 'Price', key: 'price' },
                    { title: 'Mileage', key: 'mileage' },
                    { title: 'Color', key: 'color' },
                    { title: 'Status', key: 'status' }
                ],
            };
        },
        watch: {
            // call again the method if the paramaters changes
            parameters: {
                deep: true,
                immediate: true,
                handler() {
                    this.fetchData();
                }
            }
        },
        methods: {
            //API request for a specific dealer's car.
            fetchData() {
                this.post = null;
                this.loading = true;
                const { id, sort, search } = this.parameters;
                let path = `https://localhost:7009/cars?dealerId=${id || 1}&search=${search}&sort=${sort}`;
                fetch(path)
                    .then(r => r.json())
                    .then(json => {
                        this.post = json
                        this.loading = false;
                    });
            }
        },
    });
</script>
<style scoped>
    th, td {
        padding: 10px;
        text-decoration: solid;
    }

    tabla tr td {
        border: 1px solid black;
        border-collapse: collapse;
        text-align: justify-all;
    }

    h1 {
        color: darkgreen;
        text-decoration: auto;
    }
</style>