using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CourtlyGraces : Template
    {
        public static readonly Guid ID = Guid.Parse("6311e601-54ae-4ca9-a34b-f971991aa7ab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Courtly Graces",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3bb4b4c-13cc-4db6-b2e5-8b792943f2d4"), Type = TextBlockType.Text, Text = "You were raised among the nobility or have learned proper etiquette and bearing, allowing you to present yourself as a noble and play games of influence and politics. You can use Society to (Action: Make an Impression) on a noble, as well as with (Action: Impersonate) to pretend to be a noble if you aren’t one. If you want to impersonate a specific noble, you still need to use Deception to (Action: Impersonate) normally, and to (Action: Lie) when necessary." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("feb430fa-149e-4294-ab10-ec447cef5c09"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db57cead-efce-484b-aad2-5c5005337664"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
