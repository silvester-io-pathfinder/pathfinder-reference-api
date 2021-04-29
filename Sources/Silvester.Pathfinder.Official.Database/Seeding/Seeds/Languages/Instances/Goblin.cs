﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Goblin : AbstractLanguageTemplate
    {
        public static readonly Guid ID = Guid.Parse("bbbe92c4-628e-4b49-a1fb-9845a0071980");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Goblin"
            };
        }
    }
}