using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DevastatingSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("3f51474b-bafd-4528-8736-56f70784e906");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devastating Spellstrike",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9b894e1-d687-4d5a-8698-951907938f5f"), Type = TextBlockType.Text, Text = "Your (feat: Spellstrike) sweeps are so wide and devastating, they splash onto nearby foes. Make a (feat: Spellstrike). Foes adjacent to the target take splash damage equal to 2 + the extra damage from (feat: Arcane Cascade). The damage type is the same as (feat: Arcane Cascade); if the spell already deals splash damage of the same type, combine the damage together before applying weaknesses or resistances." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ec33ceb0-de24-4ad8-9de4-77f60841468c"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("3f62ad6d-02cc-47f0-9ae5-0ed961f3dbe2"), HybridStudies.Instances.InexorableIron.ID);
            builder.HaveSpecificFeat(Guid.Parse("0fbf9bb5-8b3f-43fc-a10c-64ef5b974132"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc698405-02de-43fe-923d-47a22141105d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
