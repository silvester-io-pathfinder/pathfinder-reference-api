using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiscordantVoice : Template
    {
        public static readonly Guid ID = Guid.Parse("c447c01b-f04e-4360-80ea-292db37d87ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Discordant Voice",
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
            yield return new TextBlock { Id = Guid.Parse("18d693e1-6a05-4dea-bf64-a69a763c6e2f"), Type = TextBlockType.Text, Text = "Your (spell: inspire courage) lets loose a discordant shriek that imbues your allies' attacks with powerful sonic reverberations. While your allies are affected by your (spell: inspire courage), their weapon (action: Strikes | strike) and unarmed attacks deal an additional 1d6 sonic damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("2729d196-347b-4f0f-a7dc-c28f39fe8624"), Spells.Instances.InspireCourage.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("507c6013-8051-4b09-9757-1acfa4eb8b92"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
