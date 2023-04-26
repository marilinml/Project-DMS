<template>
    <div>
        <img alt="Car logo" width="300" src="./assets/VUE_Logo_Tight.jpg">
        <HomePage></HomePage>
    </div>
</template>

<script>
    import HomePage from './components/HomePage.vue'

    export default {
        name: 'App',
        components: {
            HomePage,
        }
    }
</script>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        margin-top: 60px;
    }
</style>
