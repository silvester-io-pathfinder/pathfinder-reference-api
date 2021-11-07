using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HiddenMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("d2f65564-e785-4eca-8478-ef878c9801e7");

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
            yield return new TextBlock { Id = Guid.Parse("34691df2-d4c8-4c8c-bc76-0b7239a72482"), Type = TextBlockType.Text, Text = "You’ve learned to hide the magical auras of your gear. During your daily preparations, you carefully tweak any or all of your magic items to appear non-magical. Objects adjusted in this way remain so until your next preparations. A spellcaster using (spell: detect magic) or (spell: read aura) must succeed at a Perception check against your Deception DC to see through your obfuscations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("07cb49a2-31bf-4b5c-bead-c6b28f1cdd71"), or => 
            {
                or.AddOr(Guid.Parse("96139245-c143-4a83-b373-505f869d940f"), or => 
                {
                    or.HaveSpecificSkillProficiency(Guid.Parse("cd4974b4-f571-4422-9af3-95b011299aa7"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("7f5b5164-4089-465f-a3b6-be5d52d88d13"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("6f48bca6-1524-4c51-942a-ff1f2d1d5980"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("84e5c968-c97c-42dd-909a-1631302c8736"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
                });
                or.HaveSpecificFeat(Guid.Parse("f876a81a-979a-43b7-ad0c-c6cdfd3adffa"), Feats.Instances.VigilanteDedication.ID);
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
                Id = Guid.Parse("25c6d473-428b-4163-88fd-fc8858e90b34"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
