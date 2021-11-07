using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConrasuWeaponUnderstanding : Template
    {
        public static readonly Guid ID = Guid.Parse("9fba80be-8247-42d7-ba1d-18891ab249af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conrasu Weapon Understanding",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27c23742-420e-4725-b559-76990761030d"), Type = TextBlockType.Text, Text = "You have come to know conrasu weapons as you know yourself. Whenever you critically hit using a (item: composite shortbow), (item: glaive), (item: longspear), (item: longsword), (item: shortbow), (item: spear), or a conrasu weapon, you apply the weapon’s critical specialization effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e10af4e0-e0c6-4e0c-a487-d98dd6604c5b"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
