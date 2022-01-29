using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedClarity : Template
    {
        public static readonly Guid ID = Guid.Parse("5c8ebd82-5505-4ca3-affe-6ebf507bf90b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Clarity",
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
            yield return new TextBlock { Id = Guid.Parse("12334600-db52-4e55-9db0-78370b4aff64"), Type = TextBlockType.Text, Text = $"You can project your premonitions of clarity to your allies. When you use {ToMarkdownLink<Models.Entities.Feat>("Premonition of Clarity", Feats.Instances.PremonitionOfClarity.ID)}, allies within 15 feet of you who failed the same saving throw against the same mental effect can also spend their reactions to reroll the failed saving throw with a +2 circumstance bonus." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("118f483e-4198-4701-be58-7a381f69fec0"), Feats.Instances.PremonitionOfClarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b06856fa-31a0-4342-8f7f-47fdcf2ac9b2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
