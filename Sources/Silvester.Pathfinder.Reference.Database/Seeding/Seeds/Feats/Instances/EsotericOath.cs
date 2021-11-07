using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EsotericOath : Template
    {
        public static readonly Guid ID = Guid.Parse("099b115b-43eb-4ef8-a439-97bb7901cada");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Esoteric Oath",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6cbad747-d212-489e-9db6-473315f86fde"), Type = TextBlockType.Text, Text = "You’ve sworn an oath to slay the alien abominations that lurk in the remote corners of Golarion. Add the following tenet to your champion’s code, after the other tenets. “You must slay evil aberrations you encounter as long as you have a reasonable chance of success.”" };
            yield return new TextBlock { Id = Guid.Parse("90784db0-fe30-4a7d-8e79-d90d9760c907"), Type = TextBlockType.Text, Text = "Your (feat: Retributive Strike) gains a +4 circumstance bonus to damage against an evil aberration, or +6 if you have master proficiency with the weapon you used. The resistance you gain from (feat: Glimpse of Redemption) against damage from an evil aberration is 7 + your level. If you use (feat: Liberating Step) triggered by an evil aberration, your ally gains a +4 circumstance bonus to checks granted by your (feat: Liberating Step), and the ally can (action: Step) twice afterward." };
            yield return new TextBlock { Id = Guid.Parse("39912973-8f94-4664-a378-d1a8445fb59e"), Type = TextBlockType.Text, Text = "You don’t consider evil aberrations to be legitimate authorities, even in nations they rule." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("2d73c417-4145-47c6-a1bb-d2a8cefe3821"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cf660ef-4652-4484-9b9a-d653d00cefdc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
