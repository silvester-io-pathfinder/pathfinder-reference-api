using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RainOfBolts : Template
    {
        public static readonly Guid ID = Guid.Parse("81f96929-d73c-4722-9944-9c3815573776");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rain of Bolts",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd784f3c-05cb-4e1a-a046-16f326aa69c5"), Type = TextBlockType.Text, Text = $"Throughout the day, your body produces powerful projectiles within your chassis. You fire them all at once in either a 30-foot cone or a 10-foot emanation. Foes in the area take 6d6 piercing damage. This increases to 7d6 at 12th level, 8d6 at 15th level, and 9d6 at 18th level." };
            yield return new TextBlock { Id = Guid.Parse("cde5d106-297d-4d47-b236-be72ea734e76"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("8653484c-1555-4620-ae82-aba314381dfe"), Type = TextBlockType.Text, Text = $"~ Enhancement: The projectiles regenerate quicker, they are much more powerful, and you can refine the metallic content to harm certain creatures. You can use Rain of Bolts once per hour instead of once per day. The damage increases to 12d6 and each time you use the action, you can choose adamantine, cold iron, or silver. The damage from Rain of Bolts is treated as the metal you chose. At 20th level, the damage increases to 13d6." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("25d009ec-7d4a-4bc8-899a-a025b5d58df7"), Heritages.Instances.SharpshooterAutomaton.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3625ae44-a53b-48fc-8a02-31830b713288"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
