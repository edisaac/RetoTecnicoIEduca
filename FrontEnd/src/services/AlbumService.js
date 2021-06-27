export default (axios, baseUrl) => {
    return {
        getAll() {
            return axios.get(`${baseUrl}album`);
        },
        get(id) {
            return axios.get(`${baseUrl}album/${id}`);
        }

      
    }
}