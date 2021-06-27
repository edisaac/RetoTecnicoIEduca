import pageDefault from './../components/Album';
import getAlbum from './../components/Section/GetAlbum';


export default [
    { path: '/', name: 'album', component: pageDefault },
    { path: '/section/:id/getalbum', name: 'getalbum', component: getAlbum },
];