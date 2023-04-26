<!-- Component Table-->
<template>
    <table class="table1" width="70%" border="0">
        <thead>
            <tr>
                <th v-for="item in header" v-bind:key="item" scope="col">
                    {{ item.title}}
                </th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="item in post" :key="item">
                <td>{{ item.model }}</td>
                <td>{{ item.price }}</td>
                <td>{{ item.mileage }}</td>
                <td>{{ item.color }}</td>
                <td>{{ item.status }}</td>
            </tr>
        </tbody>
    </table>
</template>

<script>
    export default {
        name: 'TablaBase',
        props: {
            header: { type: Array }, post: { type: Array }
        },
    };
</script>

<style>
    table1 {
        border: 1px solid black;
        border-collapse: collapse;
    }

    th {
        background-color: #2c974b;
        color: #ffffff;
        cursor: pointer;
        user-select: none;
    }

    th,
    .table1 td {
        min-width: 120px;
        padding: 10px 20px;
        text-align: center;
        border: 1px groove;
    }
</style> 