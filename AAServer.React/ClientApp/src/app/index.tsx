import React from 'react';

import * as S from './styles';

import MainHeader from '../components/mainHeader/index';
import Content from '../components/content/index';
import Footer from '../components/footer';
import SignIn from '../components/signIn/index';
import SignUp from '../components/signUp/index';

const App = () => {
  return (
    <S.Container>
      <MainHeader />
      <Content>
        <SignIn />
        <SignUp />
      </Content>
      <Footer />
    </S.Container>
  );
};

export default App;
