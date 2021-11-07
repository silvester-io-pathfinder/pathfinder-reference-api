using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuraOfVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("25c19fd1-4533-404a-9185-aff44332059d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aura of Vengeance",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("beafbf86-c153-48b7-ae4e-6d2efcbe255f"), Type = TextBlockType.Text, Text = "When you call upon others to take retribution, you also guide their aim. When you use (feat: Retributive Strike), your allies who make (action: Strikes | Strike) take only a -2 penalty, instead of a -5 penalty." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("559e570c-8670-40d7-8f44-11c4580ae3fb"), Causes.Instances.Paladin.ID);
            builder.HaveSpecificFeat(Guid.Parse("97f710e3-aab0-43ef-b428-cb2af658f506"), Feats.Instances.VengefulOath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a76b6231-0211-4375-b070-fc478d2491bd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
