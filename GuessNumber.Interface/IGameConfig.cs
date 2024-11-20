using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumber.Domain;

namespace GuessNumber.Interface
{
    public interface IGameConfig
    {
        public GameSettings Load();
        public void Save(GameSettings _settings);
    }
}
