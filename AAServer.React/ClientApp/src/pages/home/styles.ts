import styled from 'styled-components';

export const Container = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: center;
  alin-items: center;
  text-align: center;
`;

export const Button = styled.button`
  margin: 20px;
  border-radius: 8px;
  width: 350px;
  height: 55px;
  border: none;
  background: ${(props) => (props.color ? 'palevioletred' : '#2d2926')};
  color: #f2f1f0;
  font-weight: bold;
  &:hover {
    background-color: #463f3a  ;
    transition: all 0.5s ease;
`;
