using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WayfinderResonanceInfiltrator : Template
    {
        public static readonly Guid ID = Guid.Parse("47c94ab4-9a9e-479f-b522-0344bfdeacff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wayfinder Resonance Infiltrator",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("05edd2cd-d51e-474c-91e9-4a06c9f0d7df"), Type = TextBlockType.Text, Text = "You are adept at using the unusual resonance of your wayfinder to aid in any deceptions you might employ. Once per day you can activate your (item: wayfinder) to cast (spell: illusory disguise), heightened to 2nd level, as an arcane spell." };
            yield return new TextBlock { Id = Guid.Parse("219361b7-a834-48a0-83c1-3ce9ff9cd505"), Type = TextBlockType.Text, Text = "Additionally, once per day, you can activate your (item: wayfinder) with a single-action envision activation to transform it into a perfect replica of another similarly sized badge of membership or office, such as an Aspis Consortium badge. This transformation lasts for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e1babe81-544e-456a-a77f-6e960c5b173d"), Feats.Instances.PathfinderAgentDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("807128e5-0e8d-4d6f-b2b2-8fbe89487497"), Feats.Instances.WayfinderResonanceTinkerer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a0234a7-040f-4deb-84ef-26fbe2bf9f0d"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
