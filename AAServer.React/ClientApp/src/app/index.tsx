import React from 'react';

import * as S from './styles';

import MainHeader from '../components/mainHeader/index';
import SignIn from '../components/signIn/index';
import Footer from '../components/footer';

const App = () => {
  return (
    <S.Container>
      <MainHeader />
      <SignIn />
      <Footer />
    </S.Container>
  );
};

export default App;
