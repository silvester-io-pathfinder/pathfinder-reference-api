using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RootMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("23ef60ea-3213-4a86-b78e-522fac596977");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Root Magic",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("216024b9-213a-4772-80e0-e41de17b4313"), Type = TextBlockType.Text, Text = "Your talismans ward against foul magic. During your daily preparations, you can assemble a small pouch with bits of herbs, hair, sacred oils, and other ritual ingredients, which you give to one ally. The first time that day the ally attempts a saving throw against a spell or haunt, they gain a +1 circumstance bonus to the roll. This bonus increases to +2 if you’re an expert in Occultism or +3 if you’re legendary." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("062a9cdb-0183-4463-810d-285fbfb684b1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3d04b24-15ac-46d8-8acc-81a8785dd649"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
