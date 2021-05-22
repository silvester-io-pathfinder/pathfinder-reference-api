using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ArmorProficiencyFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("384659b6-1c1c-4612-9727-2d8406c2a328");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armor Proficiency",
                Level = 1,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time, you become trained in the next type of armor above.",
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("96d02376-bd63-4d35-92f0-08c08ca9f2ca"), Type = Utilities.Text.TextBlockType.Text, Text = "You become trained in light armor. If you already were trained in light armor, you gain training in medium armor. If you were trained in both, you become trained in heavy armor." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }
    }
}
