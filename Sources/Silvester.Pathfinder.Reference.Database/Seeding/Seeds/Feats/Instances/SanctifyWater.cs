using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SanctifyWater : Template
    {
        public static readonly Guid ID = Guid.Parse("a318c356-add3-4d14-b4a0-63b0d5ae360a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sanctify Water",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9a05b490-e82b-4aea-8462-536604e74a8c"), Type = TextBlockType.Text, Text = "You imbue water with your deity’s blessing. Choose a container of water on your person that is of light Bulk. For 1 round, if you or an ally throw this container at a foe, it has the damaging effects of (item: holy water) (if you follow a good deity) or (item: unholy water) (if you follow an evil deity). The water’s transient power doesn’t make it gain any value, allow it to be used to supply the cost for a spell or ritual, and so on." };
            yield return new TextBlock { Id = Guid.Parse("e24c924d-dec6-401a-8b6c-bdfaaeb29188"), Type = TextBlockType.Text, Text = "If you have legendary proficiency in Religion, you can sanctify three containers held by you or allies within your reach instead of one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c9da1152-6a58-483a-a5d5-0ced1c1e4fc5"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            builder.AddOr(Guid.Parse("c6398d8b-c182-4ebf-85a4-55aecdab6528"), or => 
            {
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("8a504a39-6db2-4004-b91d-cd0987fd20bc"), Alignments.Instances.NeutralGood.ID);
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("9ee26248-4813-44e8-96c1-c816ed6b4ebb"), Alignments.Instances.LawfulGood.ID);
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("e5cf5111-88f6-435d-8b25-ccb567be2ef3"), Alignments.Instances.ChaoticGood.ID);
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("10c48cc0-fca0-4975-a493-b568c532e419"), Alignments.Instances.LawfulEvil.ID);
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("bc868995-73d2-4728-bb0d-31147a752852"), Alignments.Instances.ChaoticEvil.ID);
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("96018f7a-bae5-436f-bba1-c7bd2b80e5a4"), Alignments.Instances.NeutralEvil.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afc632c5-beea-476e-8a8b-a7aed37f6519"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
