using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EclecticPolymath : Template
    {
        public static readonly Guid ID = Guid.Parse("94533ddc-e265-4da5-ab11-0a06c0f1229b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eclectic Polymath",
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
            yield return new TextBlock { Id = Guid.Parse("7e7345f8-a722-4c72-8bf6-5ab8b01f8077"), Type = TextBlockType.Text, Text = "Your flexible mind can quickly shift spells. If you add a spell to your repertoire during your daily preparations using (feat: Esoteric Polymath), when you prepare again, you can choose to keep the new spell from (feat: Esoteric Polymath) in your repertoire and instead lose access to another spell of the same level in your repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("369121ba-a215-4ad1-b588-f4609c760de7"), Feats.Instances.EsotericPolymath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c799dd33-99d7-409f-a77c-a65c10e623dc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
