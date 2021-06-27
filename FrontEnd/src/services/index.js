import Axios from 'axios'
import albumService from './AlbumService';


Axios.defaults.headers.common.Accept = 'application/json';

export default {
    albumService: new albumService(Axios, window.baseUrl),
}