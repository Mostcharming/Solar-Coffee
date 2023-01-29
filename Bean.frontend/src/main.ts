import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
// import store from "./store";

import './assets/main.css';

const app = createApp(App);

app.use(router);

// Vue.config.productionTip = false;

// Vue.filter("price", function(number: number) {
//   if (isNaN(number)) {
//     return "-";
//   }
//   return "€ " + number.toFixed(2);
// });

// new Vue({
//   router,
//   store,
//   render: (h) => h(App),
// }).$mount("#app");

app.mount('#app');
