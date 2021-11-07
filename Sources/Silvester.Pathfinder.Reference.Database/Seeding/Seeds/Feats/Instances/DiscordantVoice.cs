using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiscordantVoice : Template
    {
        public static readonly Guid ID = Guid.Parse("2c4042bd-a936-4797-87f0-05993fe54e15");

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
            yield return new TextBlock { Id = Guid.Parse("9592a33b-ab62-4686-b62b-d7f0220d1737"), Type = TextBlockType.Text, Text = "Your (spell: inspire courage) lets loose a discordant shriek that imbues your allies’ attacks with powerful sonic reverberations. While your allies are affected by your (spell: inspire courage), their weapon (action: Strikes | strike) and unarmed attacks deal an additional 1d6 sonic damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("86ddd703-9053-46d4-b37a-2e03d1f52d29"), Spells.Instances.InspireCourage.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("886e88b3-7b9b-4d15-8a14-5c114b6e2c56"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
