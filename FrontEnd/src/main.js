import Vue from 'vue';
import VueRouter from 'vue-router';

import App from './App.vue';
import routes from './routes/index.js';
import storeIndex from './store/index';
import services from './services/index.js';

Vue.config.productionTip = false



Vue.use({
  install(Vue) {
    Object.defineProperty(Vue.prototype, '$services', {
      value: services
    })
  }
})


Vue.use(VueRouter);
let router = new VueRouter({
  routes
});




new Vue({
  render: h => h(App),
  router

}).$mount('#app')


