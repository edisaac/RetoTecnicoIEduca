<template>
  <div id="app">
    <section class="hero is-light is-bold is-fullheight">
      <div class="hero-body">
        <div class="container">
          <router-view></router-view>
        </div>
      </div>
    </section>
    <footer class="footer">
      <div class="container has-text-centered is-size-4">
        <p>Proyecto realizado para <b>IEduca</b></p>
      </div>
    </footer>
  </div>
</template>
<script>


export default {
  name: "App",
  data() {
    
    
  },
  components: {
   
  },
  mounted() {},
};
</script>

<style></style>
