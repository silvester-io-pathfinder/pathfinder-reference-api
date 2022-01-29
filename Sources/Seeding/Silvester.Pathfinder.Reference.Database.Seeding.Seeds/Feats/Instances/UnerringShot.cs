using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnerringShot : Template
    {
        public static readonly Guid ID = Guid.Parse("c8e735cc-0c71-4156-a05a-e603f441a783");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unerring Shot",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8c3aa63c-2c5e-483e-8c70-4eacc330f11b"), Type = TextBlockType.Text, Text = $"Your senses are finely tuned to the slightest variations in the air, so much that you can place your shot exactly where you intend to aim it from any range possible with your weapon. When attacking with a ranged weapon in which you have master or greater proficiency, ignore the penalty from its range increment. (The weapon's maximum range is unchanged.) In addition, if your target has cover against your attack with such a weapon, it doesn't gain the bonus to AC if it has lesser cover, gets only the bonus of lesser cover if it has standard cover, or gains only the bonus of standard cover if it has greater cover." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff4e52ea-2e00-4eb8-8b68-764584b9ea8b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
