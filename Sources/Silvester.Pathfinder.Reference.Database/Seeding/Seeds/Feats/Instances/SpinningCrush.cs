using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpinningCrush : Template
    {
        public static readonly Guid ID = Guid.Parse("281d26aa-2b30-45e3-806a-a44c03eea2c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spinning Crush",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7feab95d-13d8-4e5a-9d1f-6cbf4897781c"), Type = TextBlockType.Text, Text = "You go into a vicious spin, smashing your weapon into those nearby and increasing your momentum by firing. All creatures adjacent to you take 1d6 bludgeoning damage plus your Strength modifier; this increases to 2d6 if your firearm has a (item: striking rune|Striking Runestone), 3d6 if it has a (item: greater striking rune|Greater Striking Runestone), and 4d6 if it has a (item: major striking rune|Major Striking Runestone). This ability does not apply other effects that increase damage with your firearm (action: Strikes|Strike) such as weapon specialization. Creatures affected by this attack must attempt a basic Reflex save. A creature that fails its save is also pushed 5 feet directly away from you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("363937d7-8d41-4375-97f0-bf983b6bfd7c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
