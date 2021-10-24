using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Methodologies.Instances
{
    public class Interrogation : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Methodology GetMethodology()
        {
            return new Methodology
            {
                Id = ID, 
                Name = "Interrogation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "People can’t help but trust you, whether through your inherent likableness or your firm insistence on sticking to the truth. You have a way about you that gets others talking, and you’ve developed interrogative techniques to help you get to the truth of your investigations." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You are trained in Diplomacy. You gain the No Cause for Alarm skill feat (page 208). You can also Pursue a Lead over the course of a conversation rather than spending dedicated time looking into the lead, provided the conversation lasts 1 minute or longer. For example, while trying to Make an Impression, you could pursue the creature you’re conversing with as a lead, and you could Pursue a Lead about an object while someone is telling you information about that object. You also gain the Pointed Question action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.NoCauseForAlarm.ID);
            //TODO: Add the Pursue a Lead modification effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 58
            };
        }
    }
}
