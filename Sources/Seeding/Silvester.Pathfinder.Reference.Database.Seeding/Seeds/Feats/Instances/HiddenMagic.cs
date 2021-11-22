using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HiddenMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("793951f3-bf31-43e3-bbb8-7aab5cfadb82");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hidden Magic",
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
            yield return new TextBlock { Id = Guid.Parse("3ca0f1e6-3e0f-4903-8921-c7a26aee704a"), Type = TextBlockType.Text, Text = "You've learned to hide the magical auras of your gear. During your daily preparations, you carefully tweak any or all of your magic items to appear non-magical. Objects adjusted in this way remain so until your next preparations. A spellcaster using (spell: detect magic) or (spell: read aura) must succeed at a Perception check against your Deception DC to see through your obfuscations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("873b32c8-8b1e-412b-8a51-013ede55de52"), or => 
            {
                or.AddOr(Guid.Parse("b1dc3907-fce4-4ce3-b49c-e8492d213f02"), or => 
                {
                    or.HaveSpecificSkillProficiency(Guid.Parse("04ef7ca6-0a8a-4f94-92af-d4151137a70b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("2aaa6523-d7d5-418c-ba79-2fc6073725c7"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("c10db1d0-93df-4de0-9f60-3d29012470d2"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("188c61f1-c741-43d2-848f-aca4d2582c94"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
                });
                or.HaveSpecificFeat(Guid.Parse("aa3e3af6-6090-484a-8dd2-212ed8bdb11e"), Feats.Instances.VigilanteDedication.ID);
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
                Id = Guid.Parse("a452d7ac-36e1-4f53-ba22-ba136034ce3e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
