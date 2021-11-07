using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LionBladeDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("edcefa53-87a2-4175-8693-d57b68f34834");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lion Blade Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Lion Blade archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94bf4ab5-cbf1-46fd-b5b9-e892ed6c722f"), Type = TextBlockType.Text, Text = "~ Access: You are from Taldor." };
            yield return new TextBlock { Id = Guid.Parse("e7aadd85-6bd1-48d6-aba1-554e5cc874cd"), Type = TextBlockType.Text, Text = "Your lion blade spy training helps you conceal yourself and your identity. You become trained in your choice of Deception or Stealth and in Espionage Lore; if you were already trained, you become an expert instead. You never take circumstance penalties for attempting to take a disguise of a different ancestry, age, and so on, as long as the disguised form is appropriate for your size." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("f4046129-af61-48ff-b29b-bd412e93f44b"), "Member of the Lion Blades");
            builder.HaveSpecificSkillProficiency(Guid.Parse("3a1f3a4d-c952-475a-86fb-5b1e67c2259e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4077f2f9-78e0-4147-b81c-3407d41dfc6f"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
