using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlanarPain : Template
    {
        public static readonly Guid ID = Guid.Parse("d0e72401-2a93-4941-9b45-abd014ae291e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Planar Pain",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("65e2bf24-8bb8-4b7d-8a80-7d76a5177883"), Type = TextBlockType.Text, Text = "When you manifest the essence form, choose one damage type: acid, chaotic, cold, electricity, evil, fire, good, lawful, negative, positive, or sonic. Attacks with the weapon deal this type of damage instead of their physical damage with a +2 status bonus to the damage." };
            yield return new TextBlock { Id = Guid.Parse("ffd7506e-6dba-4008-ab7e-50cc00a49777"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ When you deal damage with a weapon or unarmed attack, you take 2 damage of the last type you chose for planar pain, even if the damage type normally wouldn’t harm you, such as good damage if you aren’t evil." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c2c3593-7012-468c-ba26-5f70620d622b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
