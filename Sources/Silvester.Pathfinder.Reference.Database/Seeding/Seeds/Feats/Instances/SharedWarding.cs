using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedWarding : Template
    {
        public static readonly Guid ID = Guid.Parse("debc0afd-af69-4b4c-9e2b-83413951683d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Warding",
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
            yield return new TextBlock { Id = Guid.Parse("7ec9cc05-cd67-4495-9fe9-2aaeb669936c"), Type = TextBlockType.Text, Text = "You ward your allies from the attacks of your foes whenever you apply those protections to yourself. When you gain a status bonus to AC and saves from (feat: Esoteric Warden), you can also choose to grant the same benefit to all allies within 30 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0a85b510-3d85-4356-8e5b-645915905d3c"), Feats.Instances.EsotericWarden.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25f2dfb1-6ec1-4cb7-aea2-33824332e9ec"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
