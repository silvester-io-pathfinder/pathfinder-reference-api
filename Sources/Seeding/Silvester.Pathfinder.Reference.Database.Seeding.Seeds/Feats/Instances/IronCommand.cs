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
    public class IronCommand : Template
    {
        public static readonly Guid ID = Guid.Parse("400161f0-cd24-4b92-bb6b-2fad695b17e8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iron Command",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy within 15 feet damages you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3393b447-df4c-4ee1-9c8e-3ba77d603c9f"), Type = TextBlockType.Text, Text = $"You put an impertinent foe who dared harm you in their proper place. You command your enemy to kneel before you in obedience. If they dare to refuse, they must pay the price in pain and anguish. The foe must choose one of the following options." };
            yield return new TextBlock { Id = Guid.Parse("01c913bd-f10d-4f3a-912d-aaaf3ba22d8a"), Type = TextBlockType.Enumeration, Text = $" : The enemy kneels, dropping prone as a free action." };
            yield return new TextBlock { Id = Guid.Parse("636dcaa4-093e-4d8b-87a3-8522b98eab82"), Type = TextBlockType.Enumeration, Text = $" : The enemy refuses, and you deal 1d6 mental damage to it. This damage increases to 2d6 at 5th level, 3d6 at 9th level, 4d6 at 12th level, 5d6 at 16th level, and 6d6 at 19th level." };
            yield return new TextBlock { Id = Guid.Parse("c53ac637-bdb8-49e9-b483-42da35d13504"), Type = TextBlockType.Text, Text = $"In addition, your {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against the triggering creature deal 1 extra damage until the end of your next turn. You choose whether the damage type is evil or negative each time you use this reaction. This extra damage increases to 2 at 9th level and 3 at 16th level." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea89b8c9-bc6d-4824-9769-94fb6bedcb5b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
