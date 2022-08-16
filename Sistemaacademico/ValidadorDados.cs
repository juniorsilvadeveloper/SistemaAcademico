using System;
using System.Reflection;
using System.Windows.Forms;

namespace SistemaAcademico
{
	public static class ValidadorDados
	{
		public static Boolean ValidarCNPJ(string cnpj)
		{
			try
			{
				int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
				int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
				int soma;
				int resto;
				string digito;
				string tempCnpj;

				cnpj = cnpj.Trim();
				cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

				if (cnpj.Length != 14)
					return false;

				tempCnpj = cnpj.Substring(0, 12);

				soma = 0;
				for (int i = 0; i < 12; i++)
					soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

				resto = (soma % 11);
				if (resto < 2)
					resto = 0;
				else
					resto = 11 - resto;

				digito = resto.ToString();

				tempCnpj = tempCnpj + digito;
				soma = 0;
				for (int i = 0; i < 13; i++)
					soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

				resto = (soma % 11);
				if (resto < 2)
					resto = 0;
				else
					resto = 11 - resto;

				digito = digito + resto.ToString();

				return cnpj.EndsWith(digito);
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}

        public static object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            try
            {
                object retorno = "";
                if (nomeDaPropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;
                    propriedadeAntesDoPonto = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));
                    if (propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();
                        foreach (var propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno =
                                    CarregarPropriedade
                                    (
                                        propertyInfo.GetValue(propriedade, null),
                                        nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".") + 1)
                                    );
                            }
                        
                        }
                    }
                }
                else
                {
                    Type tpyPropertyType;
                    PropertyInfo pfoPropertyInfo;
                    if (propriedade != null)
                    {
                        tpyPropertyType = propriedade.GetType();
                        pfoPropertyInfo = tpyPropertyType.GetProperty(nomeDaPropriedade);
                        retorno = pfoPropertyInfo.GetValue(propriedade, null);
                    }
                }
                return retorno;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }

        public static bool ValidarData(string data)
        {
            //var dataOk = new Regex(@"(\d{2}\/\d{2}\/\d{4})");
            //return dataOk.Match(data).Success;
            DateTime dataOK;
            return DateTime.TryParse(data, out dataOK);
        }
    }
}
