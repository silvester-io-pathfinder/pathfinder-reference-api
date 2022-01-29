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
    public class PaleHorse : Template
    {
        public static readonly Guid ID = Guid.Parse("0ba471f0-0507-4a1c-a47a-50dc0a708dd3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pale Horse",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec3a1e0c-9f43-4ae8-a9c2-f739e8f84007"), Type = TextBlockType.Text, Text = $"Your mount becomes a grotesque creature of foreboding when you ride it. Its appearance transforms as flames erupt from its skin, a whorl of negative energy surrounds it, or poison leaks from its flesh. When you {ToMarkdownLink<Models.Entities.Action>("Mount", Actions.Instances.Mount.ID)} / {ToMarkdownLink<Models.Entities.Action>("Dismount", Actions.Instances.Mount.ID)} your steed ally, you can choose fire, negative, or poison. As long as you ride it, your steed gains resistance 10 to the chosen damage type, and any creature that touches your steed takes 1d6 damage of the chosen type; this includes hitting the steed with unarmed attacks or with a melee weapon {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} while adjacent to the steed. This damage increases to 2d6 at 16th level and 3d6 at 20th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("98607d3a-c5f7-4cab-bc48-162a341a161a"), DivineAllies.Instances.Steed.ID);
            builder.HaveSpecificTenet(Guid.Parse("147bbd38-2d4b-4a84-806f-b6c10e7df0f8"), Tenets.Instances.Evil.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ece2930-0b47-4d74-b786-15f31808aade"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
