using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RenewingQuills : Template
    {
        public static readonly Guid ID = Guid.Parse("90e6d0a7-c1ae-434d-9a9f-8fd8f353cbf7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Renewing Quills",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4cd6ff1f-ef46-412c-8ee6-a2b96c68fcd2"), Type = TextBlockType.Text, Text = "Your spines grow back much faster than other shisks. You can use the (feat: Barbed Quills) reaction once every 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("01ef6818-c38b-4540-b00c-eca2fe24afb3"), Heritages.Instances.QuillcoatShisk.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acae124b-7909-4533-b8e8-6f13865db806"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
