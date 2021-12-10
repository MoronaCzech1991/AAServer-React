import React from 'react';

import * as S from './styles';

type PropsContent = {
  children?: React.ReactNode;
};

const Content = ({ children }: PropsContent) => {
  return <S.Container>{children}</S.Container>;
};

export default Content;
