import React from 'react';
import * as S from './styles';

import { Link } from 'react-router-dom';

const MainHeader = () => {
  return (
    <S.Container>
      <S.Nav>
        <S.Ul>
          <S.Li>
            <Link to="/">Home</Link>
          </S.Li>
        </S.Ul>
      </S.Nav>
      <S.Nav>
        <S.Ul>
          <S.Li>
            <Link to="/signIn">Login</Link>
          </S.Li>
        </S.Ul>
      </S.Nav>
      <S.Nav>
        <S.Ul>
          <S.Li>
            <Link to="/signUp">Register</Link>
          </S.Li>
        </S.Ul>
      </S.Nav>
    </S.Container>
  );
};

export default MainHeader;
