using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefensiveArmaments : Template
    {
        public static readonly Guid ID = Guid.Parse("417b3938-3d09-4576-8a04-02095ae025a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defensive Armaments",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dc8610ac-6766-495d-a8be-da2b9f63916a"), Type = TextBlockType.Text, Text = "You use bulky firearms or crossbows to shield your body from your foes’ attacks. Any two-handed firearms and two-handed crossbows you wield gain the (trait: parry) trait. If an appropriate weapon already has the (trait: parry) trait, increase the circumstance bonus to AC it grants when used to parry from +1 to +2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ad3a70b-3290-4731-abb2-57f414647771"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
