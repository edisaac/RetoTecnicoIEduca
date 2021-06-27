<template>
  <div>
    <h1 class="title">{{ model.nombre }}</h1>
    <h2 class="subtitle">{{ model.artista }}</h2>
    <nav class="breadcrumb" aria-label="breadcrumbs">
      <ul>
      <li>
        <router-link
              class="has-text-link"
              :to="`/`">
              Inicio
            </router-link>
        </li>
        <li class="is-active">{{ model.nombre }}</li>
      </ul>
    </nav>
    <hr />
    <table class="table is-fullwidth is-striped">
      <thead>
        <tr>
          <th>Canción</th>
          <th class="has-text-right" style="width:100px;">Duracion</th>
          <th class="has-text-right" style="width:150px;">Enlace</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in model.canciones" :key="item.nombre">
          <td>{{ item.nombre }}</td>
          <td>{{ item.duracion }}</td>
          <td><a target="_blank" v-bind:href="item.enlace">Escuchar</a></td>
        </tr>
      </tbody>
      <tfoot class="has-text-weight-bold"></tfoot>
    </table>
  </div>
</template>

<script>
export default {
  name: "getalbum",
  data() {
    return {
      model: {},
    };
  },

  methods: {
    Get() {
      this.$services.albumService.get(this.$route.params.id).then((r) => {
        this.model = r.data;
      });
    },
  },
  mounted() {
    this.Get();
  },
};
</script>
