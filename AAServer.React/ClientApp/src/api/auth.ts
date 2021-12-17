const STORAGE_KEY = 'AAServer.React';

const isLogged = () => !!localStorage.getItem(STORAGE_KEY);

const login = (token: string) => localStorage.setItem(STORAGE_KEY, token);

const logout = () => localStorage.removeItem(STORAGE_KEY);

export { isLogged, login, logout };
