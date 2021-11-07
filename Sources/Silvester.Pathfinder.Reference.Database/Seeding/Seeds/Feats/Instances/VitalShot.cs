using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VitalShot : Template
    {
        public static readonly Guid ID = Guid.Parse("25c17079-e6fc-49a1-9ef8-44be20bd4cbc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vital Shot",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a19d63a7-3772-4b5f-8468-ee2f91cc9820"), Type = TextBlockType.Text, Text = "Your careful shot against an unsuspecting opponent pierces a vital artery or organ. Make a ranged (action: Strike). If the target is flat-footed, the (action: Strike) deals an extra die of weapon damage, and the foe takes persistent bleed damage equal to the amount of precision damage from your (feat: One Shot, One Kill)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4cf6c5c6-d6e2-4c02-8a75-859c6b351549"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
