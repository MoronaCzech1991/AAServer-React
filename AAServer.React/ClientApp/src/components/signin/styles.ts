import styled from 'styled-components';

export const Container = styled.div`
  min-height: 400px;
  min-width: 500px;
  margin: 100px;
  border-radius: 5px;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  background-color: #d7d2cb;
  box-shadow: 5px 10px 18px grey;
`;

export const Header = styled.div`
  margin: 20px;
`;

export const Title = styled.p`
  margin: 20px;
  font-weight: bold;
  color: #2d2926;
  font-size: 22px;
`;

export const Content = styled.div`
  margin: 20px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
`;

export const Input = styled.input`
  text-align: center;
  margin: 20px;
  width: 350px;
  height: 55px;
  border: none;
  background: #f2f1f0;
  border-radius: 3px;
`;

export const Button = styled.button`
  margin: 20px;
  width: 350px;
  height: 55px;
  border: none;
  border-radius: 8px;
  background: ${(props) => (props.color ? 'palevioletred' : '#2D2926')};
  color: #f2f1f0;
  font-weight: bold;
`;
