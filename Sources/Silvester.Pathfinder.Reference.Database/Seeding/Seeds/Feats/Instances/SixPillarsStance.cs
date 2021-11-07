using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SixPillarsStance : Template
    {
        public static readonly Guid ID = Guid.Parse("261ded9a-ca1f-4194-9a20-2bb611c36414");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Six Pillar's Stance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f69da04-bae0-489e-8109-5a1ebcc0a440"), Type = TextBlockType.Text, Text = "You stand firm, steeling your mind and body, allowing you to use your magic unperturbed. While in this stance, you gain a +4 circumstance bonus to AC against reactions triggered by using actions with the (trait: concentrate) or (trait: manipulate) traits. In addition, when you cast a spell that requires one or more actions while in this stance, your unarmed (action: Strikes | Strike) gain a +1 circumstance bonus to damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4481665c-73ee-4a0a-bade-a79d99ab1d41"), Feats.Instances.SixthPillarDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9be81541-87df-4577-9841-38a7ae73aba9"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
