using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SustainingSteel : Template
    {
        public static readonly Guid ID = Guid.Parse("ac1c3385-2e8e-4655-b7bf-cee07ac45da7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sustaining Steel",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You Cast a Spell using a spell slot.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9fec022a-2d78-4d63-b53e-e56fc3e1940b"), Type = TextBlockType.Text, Text = "You pull magic into your weapon, using its substance to transform the magic into restorative energy. You regain Hit Points equal to double the spell’s level and roll to end any persistent negative damage you have." };
            yield return new TextBlock { Id = Guid.Parse("ca05558d-0943-4c1c-855e-ac7ee2ee7bd3"), Type = TextBlockType.Text, Text = "If the spell was of the necromancy school, any persistent negative damage you have ends automatically, and you can change the damage type from (feat: Arcane Cascade) to positive if you wish. (Positive damage typically damages only undead or other creatures with negative healing.)" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c1f0e3e1-98de-40b2-a158-599e84b5647f"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("5a105082-137a-470c-b550-cf905e0c4948"), HybridStudies.Instances.InexorableIron.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea216323-26ee-46c3-be00-b48bc9c72834"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
