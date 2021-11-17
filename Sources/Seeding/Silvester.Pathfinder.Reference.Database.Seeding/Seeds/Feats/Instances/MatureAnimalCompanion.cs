using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MatureAnimalCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("23a7ca9b-97be-4d4f-aa90-fb8111a81a98");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mature Animal Companion",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da2f503f-69b1-41f9-ad06-6a291afaf04c"), Type = TextBlockType.Text, Text = "Your animal companion grows up, becoming a mature animal companion, which grants it additional capabilities. See the (Feat: animal companion) rules on page 214 for more information. Your animal companion is better trained than most. During an encounter, even if you don’t use the (Action: Command an Animal) action, your animal companion can still use 1 action on your turn that round to (Action: Stride) or (Action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eb0406a7-ef65-4b54-a09c-c467bd5eb4b2"), Feats.Instances.AnimalCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae3b6b2f-2663-4297-811e-6e23083a8b8f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
