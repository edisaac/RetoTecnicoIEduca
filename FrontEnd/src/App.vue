<template>
  <div id="app">
    <section class="hero is-light is-bold is-fullheight">
      <div class="hero-body">
        <div class="container">
          <h1 class="title">Music Store</h1>
          <h2 class="subtitle">Selecciona tu album favorito...</h2>
          <album></album>
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
import Album from "./components/Album.vue";

export default {
  name: "App",
  data() {
    return {
      album: "album"

    };
  },
  components: {
    Album,
  },
  mounted() {},
};
</script>

<style></style>
