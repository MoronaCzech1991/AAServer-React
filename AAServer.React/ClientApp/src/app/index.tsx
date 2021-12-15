import React from 'react';
import * as S from './styles';

import MainHeader from '../components/mainHeader';
import Content from '../components/content/index';
import Footer from '../components/footer';

import { BrowserRouter as Router } from 'react-router-dom';

const App = () => {
  return (
    <Router>
      <S.Container>
        <MainHeader />
        <Content />
        <Footer />
      </S.Container>
    </Router>
  );
};

export default App;
