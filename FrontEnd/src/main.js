import Vue from 'vue'
import App from './App.vue'
import services from './services/index.js'

Vue.config.productionTip = false

Vue.use({
  install(Vue) {
    Object.defineProperty(Vue.prototype, '$services', {
      value: services
    })
  }
})

new Vue({
  render: h => h(App),
}).$mount('#app')
