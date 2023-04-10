<template>
    <div>
        <p>{{ name }}</p>
        <button @click="updateName">ChangeName</button>
    </div>
</template>

<script>
export default{
    data(){
        return {
            name : "Vue2 Coder",
        }
    },

    methods: {
        updateName(){
            this.name = "Vue2 Coder Updated"
        }
    }
}
</script>

<style scoped>

</style>