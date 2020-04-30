

using System;
using System.Reflection;
using System.Reflection.Emit;

namespace _16. Reflection
{
    public class EmitTest
    {
        public static void Main()
        {
            AssemblyName sName = new AssemblyName("Name");
            AssemblyBuilder newAssembly = AssemblyBuilder.DefineDynamicAssembly(sName, AssemblyBuilderAccess.Run);

            ModuleBuilder newModule = newAssembly.DefineDynamicModule("Name");
            TypeBuilder Tp = newModule.DefineType("Type");

            MethodBuilder method = Tp.DefineMethod("method", MethodAttributes.Public, typeof(int), new Type[0]);

            ILGenerator generator = method.GetILGenerator();

            generator.Emit(OpCodes.Ldc_I4, 1);

            for (int i = 2; i <=100; i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i);
                generator.Emit(OpCodes.Add);

            }

            generator.Emit(OpCodes.Ret);
            Tp.CreateType();

            object ttt = Activator.CreateInstance(Tp);

            MethodInfo Calculate = ttt.GetType().GetMethod("method");


            
        }
    }
}