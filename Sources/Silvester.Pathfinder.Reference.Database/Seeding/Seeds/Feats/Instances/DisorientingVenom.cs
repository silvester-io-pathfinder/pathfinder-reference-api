using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisorientingVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("d2ec4d96-9bd3-44bd-82e1-6ca9777aaf28");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disorienting Venom",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26dbbb09-3563-4b0d-ac29-10ddc9645e4b"), Type = TextBlockType.Text, Text = "The venom injected by your fangs disorients your foes. A creature damaged by your anadi venom must attempt a Fortitude save against your class DC or spell DC, whichever is higher, or become flat-footed for 1 round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("82b6115b-1017-4d08-b45b-8f92ecf12236"), Heritages.Instances.VenomousAnadi.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2620218-4a2e-4c4c-8291-d474b83bd855"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
