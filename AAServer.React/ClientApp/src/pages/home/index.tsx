import React from 'react';
import * as S from './styles';

import { logout } from '../../api/auth';
import { history } from '../history';

const Home = () => {
  const handleLogout = () => {
    logout();
    history.push('/signIn');
  };

  return (
    <S.Container>
      <h1>Home</h1>
      <S.Button onClick={handleLogout}>logout</S.Button>
    </S.Container>
  );
};

export default Home;
