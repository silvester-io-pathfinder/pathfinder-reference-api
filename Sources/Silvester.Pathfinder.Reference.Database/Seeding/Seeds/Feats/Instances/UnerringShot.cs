using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnerringShot : Template
    {
        public static readonly Guid ID = Guid.Parse("2ae510af-cac5-4178-8a9d-dcc6305b5a4b");

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
            yield return new TextBlock { Id = Guid.Parse("59ff0026-8888-4df1-8252-063c9af96028"), Type = TextBlockType.Text, Text = "Your senses are finely tuned to the slightest variations in the air, so much that you can place your shot exactly where you intend to aim it from any range possible with your weapon. When attacking with a ranged weapon in which you have master or greater proficiency, ignore the penalty from its range increment. (The weapon’s maximum range is unchanged.) In addition, if your target has cover against your attack with such a weapon, it doesn’t gain the bonus to AC if it has lesser cover, gets only the bonus of lesser cover if it has standard cover, or gains only the bonus of standard cover if it has greater cover." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ceed9cee-ac7a-4361-b8a5-5a38e022b8b5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
