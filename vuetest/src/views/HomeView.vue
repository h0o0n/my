<template>
  <div>
    <h1>Vue2 Coder</h1>
    <VueCodervue/>
  </div>
</template>

<script>
import VueCodervue from '../components/VueCoder.vue';

export default{
  components:{
    VueCodervue
  },
  data() {
    return {
      name: "Vue2 Coder"
    }
  }
}

</script>

<style scoped>
h1 {
  color: antiquewhite;
}


</style>
