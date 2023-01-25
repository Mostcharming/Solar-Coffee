<script setup lang="ts">
defineProps<{
  myNumber: number;
}>()

</script>

<template>
  <h1>{{ myNumber }}</h1>
  <button>
    Click Me!
  </button>

</template>
