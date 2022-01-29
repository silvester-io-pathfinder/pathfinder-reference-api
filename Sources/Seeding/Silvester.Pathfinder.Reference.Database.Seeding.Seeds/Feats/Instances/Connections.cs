using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Connections : Template
    {
        public static readonly Guid ID = Guid.Parse("69c87ad2-5cf7-42a9-b39d-45db401fd480");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Connections",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97fad53a-0b00-49dd-b078-9c384901b838"), Type = TextBlockType.Text, Text = $"You have social connections you can leverage to trade favors or meet important people. When you're in an area with connections (typically a settlement where you've spent downtime building connections, or possibly another area in the same nation), you can attempt a Society check to arrange a meeting with an important political figure or ask for a favor in exchange for a later favor of your contact's choice. The GM decides the DC based on the difficulty of the favor and the figure's prominence." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ddd6c931-0fcc-4d32-8a3d-eb6ba02f8c38"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
            builder.HaveSpecificFeat(Guid.Parse("e4d1a196-1a72-4f63-a8c3-5dc174c6917a"), Feats.Instances.CourtlyGraces.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6bb1f2c7-632c-4d8e-a547-b9b0267a20cb"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("f46a27ec-4430-488e-a32e-21f3338601c6"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("774177ad-3c0b-4b7b-b389-6a214394ea6b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
