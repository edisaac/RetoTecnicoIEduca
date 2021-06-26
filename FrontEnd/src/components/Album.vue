<template>
  <div>

      <div class="columns is-multiline">
        <div v-for="album in albums" :key="album.id" class="column is-3">
          <div class="card">
            <div class="card-image">
              <figure class="image is-4by4">
                <img :src="album.portada" alt="Placeholder image">
              </figure>
            </div>
            <div class="card-content">
              <div class="title is-size-5">{{album.nombre}}</div>
              <div class="subtitle has-text-grey is-size-6">{{album.artista}}</div>
            </div>
          </div>
        </div>
      </div>
  </div>
</template>
<script>
export default {
  name: "album",
  data() {
    return {
      albums: [],
    };
  },
  
  methods: {
    GetAll() {
      this.$services.albumService.getAll().then((r) => {
        this.albums = r.data;
      });
    },
  },
  mounted() {
      this.GetAll();
  },
};
</script>
