using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GnollWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("62890fd4-7f64-424f-9dd0-9aaba2c62530");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnoll Weapon Familiarity",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d1c4cff-748c-4258-98de-f00f6f7e1b15"), Type = TextBlockType.Text, Text = "You were taught to be a hunter and a raider. You are trained with (item: flails | Flail), (item: khopeshes | Khopesh), (item: mambeles | Mambele), (item: spears | Spear), and (item: war flails | War Flail)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("210a599e-370a-4df4-bb7e-1a6698743cb4"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
