using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnlimitedDemesne : Template
    {
        public static readonly Guid ID = Guid.Parse("4992dd75-795e-4047-bfde-55b99d5b5b00");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unlimited Demesne",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("432d5ab3-ca24-445a-9dd1-69c069857971"), Type = TextBlockType.Text, Text = "You can move your demesne from place to place, bringing it along wherever your journey takes you. Once per day, you can invoke your demesne and call it forth, in a process that takes 1 minute. This has the effects of (spell: resplendent mansion), except that it conjures forth your demesne from its previous location, with all the benefits of Thaumaturge’s Demesne in addition to the benefits of the spell. You must be able to claim the new area as your demesne, with the same restrictions as Thaumaturge’s Demesne." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6833a81b-cb2f-405c-8cde-47e5e2f62a16"), Feats.Instances.ThaumaturgesDemesne.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f728bec8-da3a-403d-8154-4f6d64a6b6a4"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
